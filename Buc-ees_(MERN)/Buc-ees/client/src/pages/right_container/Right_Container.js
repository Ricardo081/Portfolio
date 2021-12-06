import React from 'react'
import {useState} from 'react'
import axios from 'axios'
import './Right_Container.css'
import CurrencyFormat from 'react-currency-format'
import { useStateValue } from '../../local_storage/StateProvider'
import { getBasketTotal } from '../../local_storage/Reducer'
import TableRow from '../../local_storage/data_receivers/TableRow'
    //npm install react-currency-format --legacy-peer-deps

function Right_Container() {
    const [{basket}, dispatch] = useStateValue()//for local data storage
    //Create
    //DB Access
    const [order, setOrder] = useState({
        orderMade:[],
        total:'',
    })
    const createOrder = () => {
        {basket.map(item => (
            order.orderMade.push(item)
        ))}
        order.total=getBasketTotal(basket)
        axios
          .post("http://localhost:5000/orders", order)
          .then(res => {window.location.reload(false)})
          .catch(err => console.error(err));
    }
    return (
        <div className="Right_Container">
            <div id="rTitle">
                <h1>Checkout</h1>
            </div>
            <div id="divTable">
                <table id="rTable">
                    <thead>
                        <tr>
                            <td>Item</td>
                            <td>Price</td>
                            <td>Action</td>
                        </tr>
                    </thead>
                    <tbody>
                        {basket.map(item => (
                            <TableRow
                            id={item.id}
                            itemName={item.item}
                            price={item.cost}         
                            />
                            
                        ))}
                    </tbody>
                </table>
            </div>
            <div id="rTotal">
                <CurrencyFormat
                renderText={(value) => (
                    <>
                    <p>
                        ({basket.length}) Total: <b>{value}</b>
                    </p>
                    </>
                )}
                decimalScale={2}
                value={getBasketTotal(basket)}
                displayType={"text"}
                thousandSeparator={true}
                prefix={"$"}
                />
            </div>
            <div id="rButton">
                <button onClick={createOrder}>Pay</button>
                
            </div>
        </div>
    )
}

export default Right_Container
