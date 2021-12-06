import express from 'express'
import mongoose from 'mongoose'
import cors from 'cors'
import orderRoutes from './routes/Routes.js'

const app = express()
const port = process.env.PORT || 5000;
const connection_url = "mongodb+srv://MongoAdmin:Password@cluster0.azvmm.mongodb.net/Buc-ees?retryWrites=true&w=majority"

app.use(express.json())
app.use(cors())
app.use('/orders',orderRoutes)

mongoose.connect(connection_url,{})

app.get("/", (req, res) => {
  res.status(200).send("Running!")
});

app.listen(port, () => console.log(`Server running on port ${port} 🔥`));