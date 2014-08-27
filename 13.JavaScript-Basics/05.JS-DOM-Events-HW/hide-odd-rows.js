var list = document.getElementById('third-problem');
var listTable = list.children[0];

var btnHideOddRows = document.getElementById('btnHideOddRows');
btnHideOddRows.addEventListener('click', function () {
    for (var i = 0; i < listTable.rows.length; i++) {
        if (i % 2 === 0) {
            listTable.rows[i].style.display = 'none';
        }
    }
});