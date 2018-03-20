class PaymentManager {
    constructor(title) {
        this.title = title;
    }

    render(id) {
        const container = $('#' + id);

        container.html(`
        <table>
        <caption>${this.title} Payment Manager</caption>
        <thead>
        <tr>
        <th class="name">Name</th>
            <th class="category">Category</th>
            <th class="price">Price</th>
            <th>Actions</th>
            </tr>
            </thead>
            <tbody class="payments"></tbody>
        <tfoot class="input-data">
            <tr>
            <td><input name="name" type="text"></td>
            <td><input name="category" type="text"></td>
            <td><input name="price" type="number"></td>
            <td><button>Add</button></td>
            </tr>
        </tfoot>
        </table>`);

        container.find('.input-data button').on('click', addRow);

        function addRow() {
            const nameInput = container.find('.input-data input[name=name]');
            const categoryInput = container.find('.input-data input[name=category]');
            const priceInput = container.find('.input-data input[name=price]');

            if (nameInput.val() === '' || categoryInput.val() === '' || priceInput.val() === '') {
                return;
            }

            container.find('.payments').append(
                $('<tr>')
                    .append($(`<td>${nameInput.val()}</td>`))
                    .append($(`<td>${categoryInput.val()}</td>`))
                    .append($(`<td>${Number(priceInput.val())}</td>`))
                    .append($(`<td>`)
                        .append($(`<button>`)
                            .text('Delete')
                            .on('click', deleteRow))));

            nameInput.val('');
            categoryInput.val('');
            priceInput.val('');
        }

        function deleteRow() {
            $(this).parent().parent().remove();
        }
    }
};