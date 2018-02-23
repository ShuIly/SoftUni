function attachEvents() {
    $('.load').on('click', loadCatches);
    $('.add').on('click', addCatch);

    const baseUrl = 'https://baas.kinvey.com/appdata/kid_SJn2HpTvf/';
    const user = 'shully';
    const pass = '123';

    function request(endPoint, method, data) {
        return $.ajax({
            url: baseUrl + endPoint,
            method: method,
            data: data,
            contentType: 'application/json',
            headers: {
                Authorization: 'Basic ' + btoa(user + ':' + pass)
            }
        })
    }

    function loadCatches() {
        request('biggestCatches', 'GET')
            .then(displayCatches)
            .catch(handleError);
    }

    function displayCatches(catches) {
        let htmlArr = [];
        for (let fishCatch of catches) {
            htmlArr.push(`<div class="catch" data-id="${fishCatch._id}">
            <label>Angler</label>
            <input type="text" class="angler" value="${fishCatch.angler}"/>
            <label>Weight</label>
            <input type="number" class="weight" value="${fishCatch.weight}"/>
            <label>Species</label>
            <input type="text" class="species" value="${fishCatch.species}"/>
            <label>Location</label>
            <input type="text" class="location" value="${fishCatch.location}"/>
            <label>Bait</label>
            <input type="text" class="bait" value="${fishCatch.bait}"/>
            <label>Capture Time</label>
            <input type="number" class="captureTime" value="${fishCatch.captureTime}"/>
        </div>`);
        }

        document.getElementById('catches').innerHTML = htmlArr.join('');

        // Append buttons with event listeners.
        $('.catch')
            .append($('<button class="update">Update</button>')
                .on('click', updateCatch))
            .append($('<button class="delete">Delete</button>')
                .on('click', deleteCatch));
    }

    function getFishCatch(selector) {
        let inputs = $(selector).find('input');
        return {
            angler: $(inputs[0]).val(),
            weight: Number($(inputs[1]).val()),
            species: $(inputs[2]).val(),
            location: $(inputs[3]).val(),
            bait: $(inputs[4]).val(),
            captureTime: Number($(inputs[5]).val())
        };
    }

    function addCatch() {
        request('biggestCatches', 'POST', JSON.stringify(getFishCatch('#aside')))
            .then(loadCatches)
            .catch(handleError);
    }

    function deleteCatch() {
        let id = $(this).parent().attr('data-id');
        request(`biggestCatches/${id}`, 'DELETE')
            .then(loadCatches);
    }

    function updateCatch() {
        let $catch = $(this).parent();
        let id = $catch.attr('data-id');
        request(`biggestCatches/${id}`, 'PUT', JSON.stringify(getFishCatch($catch)))
            .then(loadCatches)
            .catch(handleError);
    }

    function handleError(err) {
        console.log(err);
    }
}