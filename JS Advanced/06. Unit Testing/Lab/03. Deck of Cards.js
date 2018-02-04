function printDeckOfCards(cardArr) {
    function makeCard(face, suit) {
        const faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];
        const suits = ['S', 'H', 'D', 'C'];
        let suitToChar = {
            'S': '\u2660',
            'H': '\u2665',
            'D': '\u2666',
            'C': '\u2663'
        };

        if (!faces.includes(face) || !suits.includes(suit)) {
            throw new Error('Invalid card: ' + face + suit);
        }

        return {
            face: face,
            suit: suit,
            toString: () => face + suitToChar[suit],
        };
    }

    let deck = [];
    for (let card of cardArr) {
        let face = card.slice(0, -1);
        let suit = card[card.length - 1];
        try {
            deck.push(makeCard(face, suit));
        } catch (err) {
            console.log(err.message);
            return
        }
    }

    console.log(deck.join(' '));
}

printDeckOfCards(['AS', '10D', 'KH', '2C']);
printDeckOfCards(['5S', '3D', 'QD', '1C']);
