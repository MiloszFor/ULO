document.addEventListener("DOMContentLoaded", function () {
    const container = document.getElementById('container');
    const registerBtn = document.getElementById('register');
    const loginBtn = document.getElementById('login');

    // Add event listener for the register button
    registerBtn.addEventListener('click', function () {
        container.classList.add("active");
    });

    // Add event listener for the login button
    loginBtn.addEventListener('click', function () {
        container.classList.remove("active");
    });
});