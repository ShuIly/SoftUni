function getReportManager() {
    let reports = {};
    let sortMethod = 'ID';
    let $selected;

    let getID = (function () {
        let id = 0;
        return function () {
            return id++;
        }
    })();

    function report(author, description, reproducible, severity) {
        let rep = {
            ID: getID(),
            author: author,
            description: description,
            reproducible: reproducible,
            severity: severity,
            status: 'Open'
        };

        reports[rep.ID] = rep;
        showReports();
    }

    function setStatus(id, newStatus) {
        reports[id].status = newStatus;
        showReports();
    }

    function remove(id) {
        delete reports[id];
        showReports();
    }

    function sort(method) {
        sortMethod = method;
        showReports();
    }
    
    function output(selector) {
        $selected = $(selector);
    }

    function showReports() {
        if (!$selected) {
            return;
        }

        $selected.html('');
        let reportIDs = Object.keys(reports);
        reportIDs.sort(function (a, b) {
            if (reports[a][sortMethod] > reports[b][sortMethod]) return 1;
            if (reports[a][sortMethod] < reports[b][sortMethod]) return -1;
            return 0;
        });

        for (let id of reportIDs) {
            let rep = reports[id];
            $selected
                .append($(`<div id="report_${id}" class="report">`)
                    .append($('<div class="body">')
                        .append($(`<p>${rep.description}</p>`)))
                    .append($('<div class="title">')
                        .append($(`<span class="author">Submitted by: ${rep.author}</span>`))
                        .append($(`<span class="status">${rep.status} | ${rep.severity}</span>`))));
        }
    }

    return {
        report,
        setStatus,
        remove,
        sort,
        output
    };
}

