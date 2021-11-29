import React from 'react'
import { useState } from 'react'
import '../../App.css'
import menu from '../../json/Items.json'
import order from '../../json/Order.json'

function Menu() {
    const [items, setItems] = useState(menu);//read data from items.json

    return (
        <div id="menu">
            {items.map((item) =>
                <button style={{backgroundImage: `url(${item.image})`}}>
                    <p id="pPrice">${item.price}</p>
                    <p id="pItem">{item.item}</p>
                    
                </button>
            )}
        </div>
    )
}

export default Menu
