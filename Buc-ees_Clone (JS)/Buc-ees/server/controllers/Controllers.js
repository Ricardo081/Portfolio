import OrderData from '../models/Models.js'

export const getOrders = async (req,res) => {
    try {
        const allOrders = await OrderData.find();
        res.status(200).json(allOrders);
    } catch (error) {
        res.status(404).json({message:error.message})
    }
}

export const createOrder = async (req,res) =>{
    const order = req.body;
    const newOrder = new OrderData(order);
    try{
        await newOrder.save();
        res.status(201).json(newOrder)
    }catch(error){
        res.status(409).json({message:error.message})
    }
}

export const deleteOrder = async (req,res) => {
    const id = req.params.id;
    try {
        await OrderData.findByIdAndRemove(id).exec();
        res.send('Deletion Successfull');
    } catch (error) {
        console.log(error);
    }
}