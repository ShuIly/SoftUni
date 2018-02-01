(function () {
    function getReportedVotes(upvotes, downvotes) {
        if (upvotes + downvotes > 50) {
            let greaterVotes = Math.max(upvotes, downvotes);
            let quarterOfGreater = Math.ceil(greaterVotes / 4);
            return [upvotes + quarterOfGreater, downvotes + quarterOfGreater];
        }

        return [upvotes, downvotes];
    }

    function getRating(upvotes, downvotes) {
        let totalVotes = upvotes + downvotes;
        let balance = upvotes - downvotes;

        if (totalVotes < 10) {
            return "new";
        }

        if (upvotes / totalVotes > 0.66) {
            return "hot";
        } else if ((upvotes > 100 || downvotes > 100) && balance >= 0) {
            return "controversial";
        } else if (balance < 0) {
            return "unpopular";
        }

        return "new";
    }

    return function cmdManager(command) {
        switch (command) {
            case 'upvote':
                this.upvotes++;
                return;
            case 'downvote':
                this.downvotes++;
                return;
            case 'score':
                let rating = getRating(this.upvotes, this.downvotes);
                let [repUpvotes, repDownvotes] = getReportedVotes(this.upvotes, this.downvotes);
                let balance = repUpvotes - repDownvotes;
                return [repUpvotes, repDownvotes, balance, rating];
        }
    }
})()
