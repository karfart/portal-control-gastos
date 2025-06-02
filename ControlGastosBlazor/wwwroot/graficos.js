window.dibujarGrafico = (datos) => {
    const ctx = document.getElementById('graficoComparativo').getContext('2d');
    new Chart(ctx, {
        type: 'bar',
        data: {
            labels: datos.map(d => d.tipo),
            datasets: [
                {
                    label: 'Presupuestado',
                    data: datos.map(d => d.presupuesto),
                    backgroundColor: 'rgba(54, 162, 235, 0.7)'
                },
                {
                    label: 'Ejecutado',
                    data: datos.map(d => d.ejecutado),
                    backgroundColor: 'rgba(255, 99, 132, 0.7)'
                }
            ]
        },
        options: {
            responsive: true,
            plugins: {
                legend: { position: 'top' },
                title: { display: true, text: 'Comparativo de Presupuesto vs Ejecución' }
            }
        }
    });
};
