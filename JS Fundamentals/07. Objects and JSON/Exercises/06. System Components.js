function systemComponents(sysArr) {
    let systems = new Map();
    for (let sysInfo of sysArr) {
        sysInfo = sysInfo.split('|').map(e => e.trim()).filter(e => e !== '');
        let sysName = sysInfo[0];
        let component = sysInfo[1];
        let subcomponent = sysInfo[2];

        if (!systems.has(sysName)) {
            systems.set(sysName, new Map());
        }

        if (!systems.get(sysName).has(component)) {
            systems.get(sysName).set(component, []);
        }

        systems.get(sysName).get(component).push(subcomponent);
    }

    let sysKeys = Array.from(systems.keys())
        .sort(function (a, b) {
            let sizeDiff = systems.get(b).size - systems.get(a).size;
            if (sizeDiff !== 0) return sizeDiff;
            a = a.toLowerCase();
            b = b.toLowerCase();
            if (a > b) return 1;
            if (a < b) return -1;
            return 0;
        });

    for (let sysName of sysKeys) {
        console.log(sysName);
        for (let component of Array.from(systems.get(sysName).keys())
            .sort(function (a, b) {
                return systems.get(sysName).get(b).length - systems.get(sysName).get(a).length;
            })) {
            console.log(`|||${component}`);
            for (let subcomponent of systems.get(sysName).get(component)) {
                console.log(`||||||${subcomponent}`)
            }
        }
    }
}