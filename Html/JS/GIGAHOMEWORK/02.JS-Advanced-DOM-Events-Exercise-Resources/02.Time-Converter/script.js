function attachEventsListeners() {
    let days = document.getElementById('days');
    let hours = document.getElementById('hours');
    let minutes = document.getElementById('minutes');
    let seconds = document.getElementById('seconds');

    document.getElementById('daysBtn').addEventListener('click', function() {
        let d = Number(days.value);
        hours.value = d * 24;
        minutes.value = d * 1440;
        seconds.value = d * 86400;
    });

    document.getElementById('hoursBtn').addEventListener('click', function() {
        let h = Number(hours.value);
        days.value = h / 24;
        minutes.value = h * 60;
        seconds.value = h * 3600;
    });

    document.getElementById('minutesBtn').addEventListener('click', function() {
        let m = Number(minutes.value);
        days.value = m / 1440;
        hours.value = m / 60;
        seconds.value = m * 60;
    });

    document.getElementById('secondsBtn').addEventListener('click', function() {
        let s = Number(seconds.value);
        days.value = s / 86400;
        hours.value = s / 3600;
        minutes.value = s / 60;
    });
}