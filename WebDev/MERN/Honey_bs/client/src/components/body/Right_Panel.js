import React from 'react'
import { useState } from 'react';

import data from '../../json/Order.json'
import '../../App.css'

function Right_Panel() {
    const [items, setItems] = useState(data);
    return (
        <div id="right">
            <div id="rTitle">
                <h1>Checkout</h1>
            </div>
            <div id="rTable">
                <table id="rTable">
                    <thead>
                        <tr>
                            <th>Item</th>
                            <th>Price</th>
                        </tr>
                    </thead>
                    <tbody>
                        {items.map((item) => (
                            <tr>
                                <td>{item.item}</td>
                                <td>${item.price}</td>
                            </tr>
                        ))}
                    </tbody>
                </table>
            </div>
            <div id="rTotal">
                <p>Total: $<b>0</b></p>
            </div>
            <div id="rButton">
                <button>Pay</button>
            </div>
        </div>
    )
}

export default Right_Panel
