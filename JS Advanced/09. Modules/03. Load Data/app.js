/**
 * Created by Stoyan on 21.7.2017 г..
 */
result.data = require('./data');

function sort(property) {
    return result.data.sort((a, b) => a[property].localeCompare(b[property]));
}

function filter(property, value) {
    return result.data.filter(e => e[property] == value)
}

result.sort = sort;
result.filter = filter;


//console.log(sort('shipTo'));
//console.log('------------------');
//console.log(filter('status', 'shipped'));


