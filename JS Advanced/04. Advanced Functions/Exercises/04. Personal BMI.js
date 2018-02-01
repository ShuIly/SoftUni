function getPersonBMI(name, age, weight, height) {
    let person = {
        name: name,
        personalInfo: {
            age: age,
            weight: weight,
            height: height
        },
        BMI: getBMI(weight, height / 100),
    };

    person.status = getStatus(person.BMI);

    if (person.status === 'obese') {
        person.recommendation = 'admission required';
    }

    function getBMI(weight, height) {
        return Math.round(weight / (height * height));
    }

    function getStatus(BMI) {
        if (BMI < 18.5) return 'underweight';
        if (BMI < 25) return 'normal';
        if (BMI < 30) return 'overweight';

        return 'obese';
    }

    return person;
}

