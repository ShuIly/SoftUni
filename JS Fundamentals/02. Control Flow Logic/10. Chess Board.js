function getChessBoard(n) {
    let board = '<div class="chessboard">\n';
    for (let i = 0; i < n; ++i) {
        board += '  <div>\n';
        for (let j = 0; j < n; ++j) {
            let color = (i + j) % 2 === 0 ? "black" : "white";
            board += `    <span class="${color}"></span>\n`;
        }
        board += '  </div>\n';
    }
    board += '  </div>\n';

    console.log(board);
}
