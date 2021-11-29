import Express from "express";
import {createUser} from "../controllers/Controllers.js"

const router = Express.Router();

router.post('/',createUser);
export default router;