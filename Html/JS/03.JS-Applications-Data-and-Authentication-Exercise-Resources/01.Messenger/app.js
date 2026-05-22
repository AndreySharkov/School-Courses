function attachEvents() {
    const url = 'http://localhost:3030/jsonstore/messenger';
    const authorInput = document.getElementById('author');
    const contentInput = document.getElementById('content');
    document.getElementById('submit').addEventListener('click', async () => {
        const author = authorInput.value;
        const content = contentInput.value;
        let message = {
                author: author,
                content: content,
                }
        if (author && content) {
            await fetch(url, {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(message)
            });
            authorInput.value = '';
            contentInput.value = '';
        }
    });

    document.getElementById('refresh').addEventListener('click', async () => {
        const response = await fetch(url);
        const data = await response.json();
        const messages = Object.values(data).map(m => `${m.author}: ${m.content}`).join('\n');
        document.getElementById('messages').value = messages;
    });
}

attachEvents();