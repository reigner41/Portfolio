window.downloadFile = function(fileUrl, fileName) {
    fetch(fileUrl)
        .then(response => response.blob())
        .then(blob => {
            const link = document.createElement("a");
            link.href = URL.createObjectURL(blob);
            link.download = fileName;
            link.click();
            URL.revokeObjectURL(link.href);
        })
        .catch(console.error);
}
