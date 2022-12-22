'use strict'
const soap = require('soap');

let apiUrl = 'http://localhost:8000/PersonService.asmx'
let args = {
    age: 21,
    gender: "M",
    height: 175,
    numberOfTimesExercisePerWeek: 6,
    weight: 80,
}

async function consumeSoap() {
    try {

        let client = await soap.createClientAsync(apiUrl);
        let registeredPerson = await client.registerPersonAsync(args);

        const PERSON = { person: args };

        let protein = await client.calculateProteinIntakeAsync(PERSON);

        let calories = await client.calculateMaintenanceCaloriesAsync(PERSON);

        let bmi = await client.calculateBMIAsync(PERSON);

        console.log(PERSON, protein[0], calories[0], bmi[0]);


    } catch (error) {
        console.log(error)
    }
    }

consumeSoap()

