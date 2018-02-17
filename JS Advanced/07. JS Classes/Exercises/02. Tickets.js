function tickets(ticketsArr, sortingCriteria) {
    class Ticket{
        constructor(destination, price, status){
            this.destination = destination;
            this.price = price;
            this.status = status;
        }
    }

    let unsortedTickets = [];

    for(let ticket of ticketsArr){
        let[destination, price, status] = ticket.split('|');
        price = Number(price);
        unsortedTickets.push(new Ticket(destination, price, status));
    }

    return unsortedTickets
        .sort((a, b) => {
            if (a > b) return 1;
            if (a < b) return -1;
            return 0;
        });
}