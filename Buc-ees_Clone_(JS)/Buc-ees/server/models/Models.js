import mongoose from 'mongoose'

const orderSchema = mongoose.Schema({
    orderMade: [],
    total: Number
})

const order = mongoose.model('order',orderSchema)

export default order