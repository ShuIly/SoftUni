function radioCrystals(input) {
    function calcOperation(crystal, required) {
        if (crystal / 4 >= required) {
            return 'Cut';
        } else if (crystal - crystal / 5 >= required) {
            return 'Lap';
        } else if (crystal - 20 >= required) {
            return 'Grind';
        } else {
            return 'Etch';
        }
    }

    function operateOnCrystal(crystal, op) {
        switch (op) {
            case 'Cut':
                return crystal / 4;
            case 'Lap':
                return crystal - crystal / 5;
            case 'Grind':
                return crystal - 20;
            case 'Etch':
                return crystal - 2;
        }
    }

    function getCrystal(currTh, requiredTh) {
        let result = `Processing chunk ${currTh} microns\n`;

        if (currTh < requiredTh) {
            currTh++;
            result += `X-ray x1\nFinished crystal ${currTh} microns`;
            return result;
        }

        let operation = calcOperation(currTh, requiredTh);
        let lastOp = operation;
        let opCount = -1;

        while (currTh > requiredTh) {
            operation = calcOperation(currTh, requiredTh);
            currTh = operateOnCrystal(currTh, operation);
            opCount++;

            if (lastOp !== operation) {
                result += `${lastOp} x${opCount}\n`;
                lastOp = operation;
                opCount = 0;
                currTh = Math.floor(currTh);
                result += 'Transporting and washing\n';
            }
        }

        result += `${lastOp} x${opCount + 1}\n`;
        result += 'Transporting and washing\n';
        currTh = Math.floor(currTh);

        if (currTh < requiredTh) {
            result += `X-ray x1\n`;
            currTh++;
        }

        result += `Finished crystal ${currTh} microns`;

        return result;
    }

    for (let i = 1; i < input.length; ++i) {
        console.log(getCrystal(input[i], input[0]));
    }
}
