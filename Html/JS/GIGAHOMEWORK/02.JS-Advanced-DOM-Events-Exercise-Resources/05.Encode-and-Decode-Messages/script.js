function encodeAndDecodeMessages() {
    const textareas = document.querySelectorAll('textarea');
    const buttons = document.querySelectorAll('button');

    const encodeTextarea = textareas[0];
    const decodeTextarea = textareas[1];

    const encodeButton = buttons[0];
    const decodeButton = buttons[1];

    encodeButton.addEventListener('click', encodeMessage);
    decodeButton.addEventListener('click', decodeMessage);

    function encodeMessage() {
        let message = encodeTextarea.value;
        let encodedMessage = '';
        for (let i = 0; i < message.length; i++) {
            encodedMessage += String.fromCharCode(message.charCodeAt(i) + 1);
        }
        decodeTextarea.value = encodedMessage;
        encodeTextarea.value = '';
    }

    function decodeMessage() {
        let encodedMessage = decodeTextarea.value;
        let decodedMessage = '';
        for (let i = 0; i < encodedMessage.length; i++) {
            decodedMessage += String.fromCharCode(encodedMessage.charCodeAt(i) - 1);
        }
        decodeTextarea.value = decodedMessage;
    }
}