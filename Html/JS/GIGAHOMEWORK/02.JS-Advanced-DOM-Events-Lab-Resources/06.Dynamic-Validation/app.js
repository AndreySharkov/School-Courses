function validate() {
    let email = document.getElementById('email');
    email.addEventListener('change', onChange);

    function onChange(ev) {
        let email = ev.target;
        let pattern = /^[a-z]+@[a-z]+\.[a-z]+$/;

        if (pattern.test(email.value)) {
            email.classList.remove('error');
        } else {
            email.classList.add('error');
        }
    }
}