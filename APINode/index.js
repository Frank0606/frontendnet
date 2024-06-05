const express = require('express')
const cors = require("cors")
const dotenv = require('dotenv')
const app = express()

dotenv.config()

app.use(express.json())
app.use(express.urlencoded({ extended: false }))

var corsOptions = {
    origin: ["https://localhost:3301", "https://localhost:8080"],
    methods: "GET,PUT,POST,DELETE",
};
app.use(cors(corsOptions))

app.use("/api/categorias", require('./routes/categorias.routes'))
app.use("/api/peliculas", require('./routes/peliculas.routes'))
app.get("*", (req, res) => { res.status(404).send() })

const errorhandler = require('./middlewares/errorhandler')
app.use(errorhandler)

app.listen(process.env.SERVER_PORT, () => {
    console.log(`Aplicacion de ejemplo escucha en el puerto ${process.env.SERVER_PORT}`)
})