function solve() {
    let section = document.querySelector('main section');
    let createButton = document.querySelector('.btn.create');
    let creatorInput = document.getElementById('creator');
    let titleInput = document.getElementById('title');
    let contentInput = document.getElementById('content');

    createButton.addEventListener('click', (ev) => {
        ev.preventDefault();

        if (!creatorInput.value || !titleInput.value || !contentInput.value) {
            return;
        }

        section.innerHTML += `
        <article>
            <h1>${titleInput.value}</h1>
            <p>Creator: ${creatorInput.value}</p>
            <p>${contentInput.value}</p>
            <div class="buttons">
                <button class="btn delete">Delete</button>
                <button class="btn edit">Edit</button>
            </div>
        </article>`;

        creatorInput.value = '';
        titleInput.value = '';
        contentInput.value = '';
    });

    section.addEventListener('click', (ev) => {
        if (ev.target.classList.contains('delete')) {
            ev.target.parentElement.parentElement.remove();
        } else if (ev.target.classList.contains('edit')) {
            const article = ev.target.parentElement.parentElement;
            titleInput.value = article.querySelector('h1').textContent;
            creatorInput.value = article.querySelector('p').textContent.replace('Creator: ', '');
            contentInput.value = article.querySelectorAll('p')[1].textContent;
            article.remove();
        }
    });
}
