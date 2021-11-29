import userData from "../models/Models.js"

export const createUser = async (req,res) => {
    const user = req.body;
    const newUser = new userData(user);
    try {
        await newUser.save();
        res.status(201).json(newUser);
    }catch (error){
        res.status(409).json({message:error.message});
    }
}