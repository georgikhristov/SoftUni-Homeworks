var numberInput = document.getElementById('fourth-problem-input');
var previousValue = numberInput.value;
numberInput.addEventListener('keyup', function (ev) {
    var target = ev.target;
    var value = target.value;

    if (isNaN(value)) {
        target.value = previousValue;
        numberInput.style.backgroundColor = 'red';
        numberInput.setAttribute('readonly', 'readonly');

        setTimeout(function () {
            numberInput.style.backgroundColor = 'white';
            numberInput.removeAttribute('readonly');
        }, 1000);
    }
    else {
        previousValue = value;
        numberResult.innerText = previousValue;
    }
});