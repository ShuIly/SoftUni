function attachEvents() {
    const weatherSymbols = {
        Sunny: '&#x2600',
        'Partly sunny': '&#x26C5',
        Overcast: '&#x2601',
        Rain: '&#x2614',
        Degrees: '&#176',
    };

    const baseUrl = 'https://judgetests.firebaseio.com/';
    const $forecast = $('#forecast');

    function request(endpoint) {
        return $.ajax({
            url: baseUrl + endpoint,
        })
    }

    $('#submit').on('click', getWeather);

    function getWeather() {
        request('locations.json')
            .then(requestWeather)
            .catch(handleError)
            .then($forecast.css('display', 'block'));
    }

    function requestWeather(locations) {
        let searchName = $('#location').val();
        let targetLocation = locations.find(l => l.name === searchName);
        if (targetLocation === undefined) {
            throw new Error('Location not found!');
        }

        let targetCode = targetLocation.code;
        let currentWeatherP = request(`forecast/today/${targetCode}.json`);
        let upcomingWeatherP = request(`forecast/upcoming/${targetCode}.json`);

        Promise.all([currentWeatherP, upcomingWeatherP])
            .then(displayWeather);
    }

    function displayWeather([currWeather, upcomingWeather]) {
        let condition = currWeather.forecast.condition;
        $forecast.empty()
            .append($('<div id="current">')
                .append($('<div class="label">Current conditions</div>'))
                .append($(`<span class="condition symbol">${weatherSymbols[condition]}</span>`))
                .append($('<span class="condition">')
                    .append($(`<span class="forecast-data">${currWeather.name}</span>`))
                    .append($(`<span class="forecast-data">${currWeather.forecast.low}/${currWeather.forecast.high}</span>`))
                    .append($(`<span class="forecast-data">${condition}</span>`))))
            .append($('<div id="upcoming">')
                .append($('<div class="label">Three-day forecast</div>')));

        let $upcoming = $('#upcoming');
        for (let weather of upcomingWeather.forecast) {
            $upcoming.append($('<span class="upcoming">')
                .append($(`<span class="symbol">${weatherSymbols[weather.condition]}</span>`))
                .append($(`<span class="forecast-data">${weather.low}/${weather.high}</span>`))
                .append($(`<span class="forecast-data">${weather.condition}</span>`)));
        }

    }

    function handleError(err) {
        $forecast.empty().append($(`<span id="error">Error: ${err.message}</span>`));
    }
}