function administerCrew(workerObj) {
    if (workerObj.handsShaking) {
        workerObj.bloodAlcoholLevel += workerObj.weight * workerObj.experience / 10;
        workerObj.handsShaking = false;
    }

    return workerObj;
}