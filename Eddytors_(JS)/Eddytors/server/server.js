import express from 'express'
import mongoose from 'mongoose'
import cors from 'cors'
import userRoutes from './routes/Routes.js'

const app = express()
const port = process.env.PORT || 5000;
const connection_url = "mongodb+srv://MongoAdmin:Password@cluster0.71y9c.mongodb.net/Eddytors?retryWrites=true&w=majority"

app.use(express.json())
app.use(cors())
app.use('/users',userRoutes)

mongoose.connect(connection_url,{})

app.get("/", (req, res) => {
  res.status(200).send('Running Eddytors Back!')
});

app.listen(port, () => console.log(`Server running on port ${port} 🔥`));