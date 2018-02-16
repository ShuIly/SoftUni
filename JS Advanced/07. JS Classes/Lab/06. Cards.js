function Cards() {
    (function () {
        let Suits = {
            SPADES: '♠',
            HEARTS: '♥',
            DIAMONDS: '♦',
            CLUBS: '♣',
        };
        class Card {
            static get validFaces() {
                return ["2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"];
            }

            constructor(face, suit) {
                this.face = face;
                this.suit = suit;
            }

            get face() {
                return this._face;
            }

            set face(value) {
                if (!Card.validFaces.includes(value)) {
                    throw new Error();
                }
                this._face = value;
            }

            get suit() {
                return this._suit;
            }

            set suit(value) {
                this._suit = value;
            }

            toString() {
                return this._face + this._suit;
            }
        }

        return {
            Suits: Suits,
            Card: Card
        }
    })()
}
