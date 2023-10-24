function getAllUsers() {
    fetch("/api/Users/getAll")
        .then(response => response.json())
        .then(data => {
            document.getElementById("allUsers").innerHTML = JSON.stringify(data);
        });
}

function getUser() {
    const userId = document.getElementById("userId").value;
    fetch(`/api/Users/${userId}`)
        .then(response => response.text())
        .then(data => {
            document.getElementById("user").innerHTML = JSON.stringify(data);
        });
}