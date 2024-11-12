function addCalorieEntry(event) {
    event.preventDefault();
    const date = document.getElementById('entry-date').value;
    const calories = document.getElementById('entry-calories').value;
    const tableBody = document.getElementById('calorieTableBody');

    const row = document.createElement('tr');
    row.innerHTML = `<td>${date}</td><td>${calories}</td>`;
    tableBody.appendChild(row);

    event.target.reset();
}
