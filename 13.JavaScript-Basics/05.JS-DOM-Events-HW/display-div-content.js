var divs = document.querySelectorAll('#second-problem div');
var result = document.getElementById('result');

var fragment = document.createDocumentFragment();
var liModel = document.createElement('li');

for (var div in divs) {
    if (divs[div] instanceof HTMLDivElement && !(divs[div].classList.contains('empty'))) {
        var currentLi = liModel.cloneNode(true);
        currentLi.textContent = divs[div].innerText;
        fragment.appendChild(currentLi);
    }
}

result.appendChild(fragment);