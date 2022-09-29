window.onload = function () {
    document.getElementById("download").addEventListener("click", () => {
        const body = this.document.getElementById("body");
        var opt = {
            margin: 0,
            filename: 'report.pdf',
            image: {type: 'jpeg', quality: 0.98},
            html2canvas: {scale: 1.5},
            jsPDF: {unit: 'in', format: 'letter', orientation: 'landscape'}
        };
        html2pdf().from(body).set(opt).save();
    });
}
    