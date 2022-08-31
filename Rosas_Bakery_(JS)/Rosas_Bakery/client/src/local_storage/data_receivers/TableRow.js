import React from 'react'
import { useStateValue } from '../StateProvider'
import '../../pages/right_container/Right_Container.css'

function TableRow({id,itemName,price}) {
    const [{basket},dispatch] = useStateValue()
    const removeFromBasket = () => {
        dispatch({
            type: 'REMOVE_FROM_BASKET',
            id: id,
        })
    }
    return (
        <tr>
            <td>{itemName}</td>
            <td>{price}</td>
            <td><button id="btnDelete" onClick={removeFromBasket}>Delete</button></td>
        </tr>
    )
}

export default TableRow
