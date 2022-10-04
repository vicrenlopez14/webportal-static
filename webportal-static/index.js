const express = require('express');
const app = express();
const port = process.env.PORT || 3000;

const path = require('path')

app.use(express.static(path.join(__dirname, 'public/')));

app.get('/', (req, res) => {
    res.redirect('/Inglés/index.html');
    // res.sendFile(path.join(__dirname, "./public/Inglés/index.html"));
});

app.get('/es', (req, res) => {
    res.redirect('/Español/Español.html');
});

app.get('/en', (req, res) => {
    res.redirect('/Inglés/index.html');
});

app.listen(port, () => console.log(`ProFind static page listening on port ${port}!`));