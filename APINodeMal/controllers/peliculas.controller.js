const { where } = require('sequelize')
const { pelicula } = require('../models')
let self = {}

self.getAll = async function (req, res) {

    try {
        const { s } = req.query

        const filters = {}

        if(s) {
            filters.titulo = {
                [Op.like]: `%${s}%`
            }
        }

        let data = await pelicula.findAll({
            where: filters,
            attributes: [['id', 'peliculaid'], 'titulo', 'sinopsis', 'anio', 'poster'],
            incluse: {
                model: categoria,
                as: 'categoria',
                attributes: [['id', 'categoriaid'], 'nombre', 'protegida'],
                through: { attributes: [] }
            },
            subQuery: false
        })
        return res.status(200).json(data)
    } catch(error) {
        return res.status(500).json(error)
    }
}

self.get = async function (req, res) {
    try {
        let id = req.params.id
        let data = await pelicula.findByPk(id, {
            attributes: [['id', 'peliculaid'], 'titulo', 'sinopsis', 'anio', 'poster'],
            include: {
                model: categoria,
                as: 'categoria',
                attributes: [['id', 'categoriaid'], 'nombre', 'protegida'],
                through: { attributes: [] }
            }
        })
        if(data){
            return res.status(200).json(data)
        } else {
            return res.status(404).send()
        }
    } catch (error) {
        return res.status(500).json(error)        
    }
}

self.create = async function (req, res) {
    try {
        let data = await pelicula.create({
            titulo: req.body.titulo,
            sinopsis: req.body.sinopsis,
            anio: req.body.anio,
            poster: req.body.poster,
        })
        return res.status(201).json(data)
    } catch (error) {
        return res.status(500).json(error) 
    }
}

self.update = async function (req, res) {
    try {
        let id = req.params.id
        let body = req.body
        let data = await pelicula.update(body, { where: { id: id } })
        if(data[0] === 0){
            return res.status(404).send()
        } else {
            return res.status(204).send()
        }
    } catch (error) {
        return res.status(500).json(error) 
    }
}

self.delete = async function (req, res) {
    try {
        let id = req.params.id
        let data = await pelicula.findByPk(id)
        if(!data){
            return res.status(404).send()
        }
        if(data.protegida){
            return res.status(400).send()
        }
        if(data === 1){
            return res.status(204).send()
        } else {
            return res.status(404).send()
        }
    } catch (error) {
        return res.status(500).json(error)
    }
}

module.exports = self