function focused() {
    let inputs = document.getElementsByTagName('input');

    for (let i = 0; i < inputs.length; i++) {
        inputs[i].addEventListener('focus', onFocus);
        inputs[i].addEventListener('blur', onBlur);
    }

    function onFocus(ev) {
        ev.target.parentElement.classList.add('focused');
    }

    function onBlur(ev) {
        ev.target.parentElement.classList.remove('focused');
    }
}