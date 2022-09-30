const express = require('express');
const app = express();
const port = process.env.PORT || 3000;

const path = require('path')

app.use(express.static(path.join(__dirname, 'public/Español')));
app.use(express.static(path.join(__dirname, 'public/Inglés')));

app.get('/', (req, res) => {
    res.sendFile(path.join(__dirname, "./public/Inglés/index.html"));
});

app.get('/es', (req, res) => {
    res.sendFile(path.join(__dirname, "./public/Español/Español.html"));
});

app.get('/en', (req, res) => {
    res.sendFile(path.join(__dirname, "./public/Inglés/index.html"));
});

app.listen(port, () => console.log(`Example app listening on port ${port}!`));