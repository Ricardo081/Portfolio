import React from 'react'
import '../../pages/mid_container/styles/Mid_Container.css'
import {useStateValue} from '../StateProvider'

function Button({id, itemName, image, price}) {
    //push to data layer
    const [{basket}, dispatch] = useStateValue()
    console.log('basket >>> ', basket)
    const addToBasket = () => {
        dispatch({
            type: 'ADD_TO_BASKET',
            item: {
                id: id,
                item: itemName,
                cost: price
            }
        })
    }
    return (
        <div>
            <button 
            style={{backgroundImage: `url(${image})`}} 
            onClick={addToBasket}
            >
                <p id="pPrice">${price}</p>
                <p id="pItem">{itemName}</p>
            </button>
        </div>
    )
}

export default Button
