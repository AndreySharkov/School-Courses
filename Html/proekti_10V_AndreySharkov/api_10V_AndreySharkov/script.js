
function getWeather(){
    fetch('https://api.open-meteo.com/v1/forecast?latitude=42.6977&longitude=23.3242&current_weather=true')
    .then(response => response.json())
    .then(data =>{
        console.log(data);
        const container = document.querySelector('.container');
        const { 
            current_weather,
            current_weather_units
        } = data;
        const {
            temperature,
            weathercode: current_weather_code,
            windspeed
        } = current_weather;
        
        
        container.innerHTML = `
        <p>Weather temperature:${temperature}</p>
        <p>Weather code: ${current_weather_code}</p>
        <p>Wind speed: ${windspeed}</p>
        `
        const timeContainer = document.querySelector('.time');
        timeContainer.innerHTML = ` <p>time: ${data.current_weather.time}</p>`

        
    })

}

getWeather();