window.addEventListener("load", function () {
    let submitButton = document.getElementById("submitButton");
    let cityInput = document.getElementById("cityInput");
    let countryInput = document.getElementById("countryInput");
    let city = document.getElementById("city");
    let currentTemp = document.getElementById("currentTemp"); 
    let currentIcon = document.getElementById("currentIcon"); 
    let currentCondition = document.getElementById("currentCondition"); 
    let currentHumidity = document.getElementById("currentHumidity"); 
    let currentFeelsLike = document.getElementById("currentFeelsLike"); 
    let currentWindSpeed = document.getElementById("currentWindSpeed");
    let currentLow = document.getElementById("currentLow");
    let currentHigh = document.getElementById("currentHigh");
    
    // Hide the upcoming weather forecast
    let hide = document.getElementById("hide");
    hide.style.display = "none";

    // Weather data for first forecast
    let weatherData1 = {
        time: document.getElementById("time"),
        feelsLike: document.getElementById("feelsLike"),
        temp: document.getElementById("temp"),
        tempMin: document.getElementById("tempMin"),
        tempMax: document.getElementById("tempMax"),
        description: document.getElementById("description"),
        icon: document.getElementById("icon")
    };

    let weatherData2 = {
        time: document.getElementById("time2"),
        feelsLike: document.getElementById("feelsLike2"),
        temp: document.getElementById("temp2"),
        tempMin: document.getElementById("tempMin2"),
        tempMax: document.getElementById("tempMax2"),
        description: document.getElementById("description2"),
        icon: document.getElementById("icon2")
    };

    let weatherData3 = {
        time: document.getElementById("time3"),
        feelsLike: document.getElementById("feelsLike3"),
        temp: document.getElementById("temp3"),
        tempMin: document.getElementById("tempMin3"),
        tempMax: document.getElementById("tempMax3"),
        description: document.getElementById("description3"),
        icon: document.getElementById("icon3")
    };
   
    let weatherData4 = {
        time: document.getElementById("time4"),
        feelsLike: document.getElementById("feelsLike4"),
        temp: document.getElementById("temp4"),
        tempMin: document.getElementById("tempMin4"),
        tempMax: document.getElementById("tempMax4"),
        description: document.getElementById("description4"),
        icon: document.getElementById("icon4")
    };

    let weatherData5 = {
        time: document.getElementById("time5"),
        feelsLike: document.getElementById("feelsLike5"),
        temp: document.getElementById("temp5"),
        tempMin: document.getElementById("tempMin5"),
        tempMax: document.getElementById("tempMax5"),
        description: document.getElementById("description5"),
        icon: document.getElementById("icon5")
    };


    submitButton.addEventListener('click', function () {

        // Display the hidden upcoming weather forecast
        hide.style.display = "block";
      
        // Get the user's location 
        fetch('http://api.openweathermap.org/geo/1.0/direct?q=' + cityInput.value + ',' + countryInput.value + '&limit=5&appid=22d07ca9f186c1bda493b1c7182b36ae')
            .then(response => response.json())
            .then(geolocationData => {
                console.log(geolocationData);

                let latData = geolocationData[0]['lat'];
                let lonData = geolocationData[0]['lon'];

                // Fetch weather forecast data
                fetch('https://api.openweathermap.org/data/2.5/forecast?lat=' + latData + '&lon=' + lonData + '&appid=22d07ca9f186c1bda493b1c7182b36ae&units=metric')
                    .then(response => response.json())
                    .then(data => {
                        console.log(data);

                        // Process weather data
                        processWeatherData(data.list[0], weatherData1);
                        processWeatherData(data.list[1], weatherData2);
                        processWeatherData(data.list[2], weatherData3)
                        processWeatherData(data.list[3], weatherData4);
                        processWeatherData(data.list[4], weatherData5);

                        // display the city and the country
                        let cityData = data.city.name; 
                        let countryData = data.city.country; 
                        city.innerHTML = cityData + ", " + countryData;
                        
                    });

                    // Fetch the current weather forecast
                fetch('https://api.openweathermap.org/data/2.5/weather?lat=' + latData + '&lon=' + lonData + '&appid=22d07ca9f186c1bda493b1c7182b36ae&units=metric')
                    .then(response => response.json())
                    .then(currentData => {
                        console.log(currentData);
                        
                        let currentTempData = currentData.main.temp; 
                        currentTemp.innerHTML = currentTempData + "&#8451"; 

                        let currentIconData = currentData.weather[0].icon; 
                        currentIcon.src = 'http://openweathermap.org/img/wn/' + currentIconData  + '.png';

                        let currentConditionData = currentData.weather[0].description;
                        currentCondition.innerHTML = "conditions: " + currentConditionData;

                        let humidityData = currentData.main.humidity
                        currentHumidity.innerHTML = "humidity: " + humidityData + "%";

                        let currentFeelsLikeData = currentData.main.feels_like
                        currentFeelsLike.innerHTML = "feels like: " + currentFeelsLikeData + "&#8451";

                        let windSpeedData = currentData.wind.speed
                        currentWindSpeed.innerHTML = "wind speed: " + windSpeedData + "m/s";

                        let currentlowData = currentData.main.temp_min
                        currentLow.innerHTML = "low: " + currentlowData + "&#8451";

                        let currentHighData = currentData.main.temp_max
                        currentHigh.innerHTML = "high: " + currentHighData + "&#8451";

                    })
            });
    });

    // Function to process weather data and update HTML elements
    function processWeatherData(forecast, weatherElements) {
        weatherElements.time.innerHTML = forecast.dt_txt;
        weatherElements.feelsLike.innerHTML = 'Feels Like: ' + forecast.main.feels_like;
        weatherElements.temp.innerHTML = 'Temperature: ' + forecast.main.temp;
        weatherElements.tempMin.innerHTML = 'Low: ' + forecast.main.temp_min;
        weatherElements.tempMax.innerHTML = 'High: ' + forecast.main.temp_max;
        weatherElements.description.innerHTML = forecast.weather[0].description;
        weatherElements.icon.src = 'http://openweathermap.org/img/wn/' + forecast.weather[0].icon + '.png';
    }
});
