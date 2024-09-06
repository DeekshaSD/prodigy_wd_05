/* styles.css */
body {
    font-family: Arial, sans-serif;
    background: linear-gradient(to right, #007bff, #00c6ff);
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
    margin: 0;
    color: white;
}

.container {
    text-align: center;
    background-color: rgba(255, 255, 255, 0.1);
    padding: 30px;
    border-radius: 10px;
    box-shadow: 0 0 15px rgba(0, 0, 0, 0.3);
}

h1 {
    margin-bottom: 20px;
    font-size: 2.5rem;
}

.weather-form {
    margin-bottom: 20px;
}

.weather-form input {
    padding: 10px;
    border-radius: 5px;
    border: none;
    outline: none;
}

.weather-form button {
    padding: 10px 20px;
    margin-left: 10px;
    border-radius: 5px;
    border: none;
    background-color: #4b4bff;
    color: white;
    cursor: pointer;
    transition: background-color 0.3s;
}

.weather-form button:hover {
    background-color: #007bff;
}

.weather-info {
    font-size: 1.2rem;
}

.weather-info p {
    margin: 5px 0;
}
