function lockedProfile() {
    let buttons = Array.from(document.getElementsByTagName('button'));

    buttons.forEach(button => {
        button.addEventListener('click', function(e) {
            let profile = e.target.parentElement;
            let hiddenDiv = profile.querySelector('div');
            let unlockRadio = profile.querySelector('input[value="unlock"]');

            if (unlockRadio.checked) {
                if (e.target.textContent === 'Show more') {
                    hiddenDiv.style.display = 'block';
                    e.target.textContent = 'Hide it';
                } else {
                    hiddenDiv.style.display = 'none';
                    e.target.textContent = 'Show more';
                }
            }
        });
    });

    let hiddenFields = Array.from(document.querySelectorAll('div[id$="HiddenFields"]'));
    hiddenFields.forEach(div => div.style.display = 'none');
}