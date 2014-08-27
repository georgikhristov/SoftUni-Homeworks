var mousePositionContainer = document.getElementById('fifth-problem');
var mouse = { x: 0, y: 0 };

document.addEventListener('mousemove', function (e) {
    mouse.x = e.clientX || e.pageX;
    mouse.y = e.clientY || e.pageY;
    mousePositionContainer.innerText = 'X: ' + mouse.x + ' Y: ' + mouse.y;
}, false);