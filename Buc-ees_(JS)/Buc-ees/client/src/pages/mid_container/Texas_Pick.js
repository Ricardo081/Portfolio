import React from 'react'
import {useState} from 'react'
import Texas_Pick from '../../resources/json_files/texas_pick.json'
import Button from '../../local_storage/data_receivers/Button';
import './styles/Mid_Container.css'

function Mid_Container() {
    const [items] = useState(Texas_Pick);

    return (
        
        <div className="Mid_Container">
            {items.map((item) =>
            <Button
            id={item.id}
            itemName={item.item}
            price={item.price}
            image={item.image}
            />
            )}
        </div>
       
    )
}

export default Mid_Container
