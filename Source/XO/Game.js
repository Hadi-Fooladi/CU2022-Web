const X = "X";
const O = "O";
const B = "B";
const Invalid = "Invalid";
const Valid = "Valid";
const Draw = "Draw";

class Game {
    constructor() {
        this.a = [B, B, B, B, B, B, B, B, B];
        this.turn = X;
    }

    Play(ndx) {
        if (ndx < 0 || ndx > 8) return Invalid;

        const a = this.a;
        if (a[ndx] != B) return Invalid;

        a[ndx] = this.turn;
        this.turn = this.turn == X ? O : X;

        if (this.IsWinner(X)) return X;
        if (this.IsWinner(O)) return O;

        for (let i = 0; i < 9; i++)
            if (a[i] == B)
                return Valid;

        return Draw;
    }

    IsWinner(p) {
        const a = this.a;
        return (
            a[0] == p && a[1] == p && a[2] == p ||
            a[3] == p && a[4] == p && a[5] == p ||
            a[6] == p && a[7] == p && a[8] == p ||
            a[0] == p && a[3] == p && a[6] == p ||
            a[1] == p && a[4] == p && a[7] == p ||
            a[2] == p && a[5] == p && a[8] == p ||
            a[0] == p && a[4] == p && a[8] == p ||
            a[2] == p && a[4] == p && a[6] == p);
    }

    Get(ndx) {
        return this.a[ndx];
    }
}
