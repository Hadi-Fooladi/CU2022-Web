const game = new Game();
const imgList = [];
for (let i = 0; i < 9; i++) {
    const img = document.getElementById(`img${i}`);
    img.onclick = () => Play(i);
    imgList.push(img);
}

function Play(ndx) {
    const result = game.Play(ndx);
    if (result == Invalid) {
        alert("Invalid move");
        return;
    }

    UpdateUI();

    if (result == Valid) return;

    if (result == Draw) {
        alert("Draw");
        return;
    }

    alert(`${result} wins`);
}

function UpdateUI() {
    for (let i = 0; i < 9; i++) {
        let src;
        switch (game.Get(i)) {
            default: src = "B.png"; break;
            case X: src = "X.png"; break;
            case O: src = "O.png"; break;
        }
        imgList[i].src = src;
    }
}
