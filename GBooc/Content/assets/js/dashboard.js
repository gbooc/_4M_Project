//  translate it to angular js

window.onload = function () {


    var ctx = document.getElementById("grphAll4m");

    var hwBarchart = new Chart(ctx, {
        type: 'bar',
        data: {
            labels: ['TD', 'PD', 'PCD', 'PQA'],
            datasets: [{
                label: "All On-going 4M",
                data: [12, 19, 3, 5, 2, 3],
                backgroundColor: [
                    'rgba(255, 99, 132, 0.2)',
                    'rgba(54, 162, 235, 0.2)',
                    'rgba(255, 206, 86, 0.2)',
                    'rgba(75, 192, 192, 0.2)',
                    
                ],
                borderColor: [
                    'rgba(255, 99, 132, 1)',
                    'rgba(54, 162, 235, 1)',
                    'rgba(255, 206, 86, 1)',
                    'rgba(75, 192, 192, 1)',
                ],
                borderWidth: 1
            }]
        },
        options: {
            responsive: true,
            title: {
                display: true,
                text: "All On-going 4M"
            },
            tooltips: {
                mode: 'label',
                bodySpacing: 10,
                cornerRadius: 0,
                titleMarginBottom: 15,
            },
            scales: {
                xAxes: [{
                    barPercentage: 1,
                    categoryPercentage: 0.6
                }]
            }
        }
    });
};