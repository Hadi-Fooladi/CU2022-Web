const game = new Game();
const imgList = [];
const t = document.getElementById("t");

for (let row = 0; row < 3; row++) {
    const tr = document.createElement("tr");
    t.appendChild(tr);

    for (let col = 0; col < 3; col++) {
        const td = document.createElement("td");
        tr.appendChild(td);

        const num = row * 3 + col;
        const img = document.createElement("img");
        img.onclick = () => Play(num);
        imgList.push(img);
        td.appendChild(img);
    }
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
