import React, {useState} from 'react'
import './Home.css'
import imgs from '../../portfolio.json'

function Home() {
    const [portfolioImgs] = useState(imgs)
    return (
        <div className="Home">
            <div id="jumb">
                <h1>Let others view you how you view yourself.</h1>
                <p>Hi, there I'm Eddy! My team and I have helped hundreds of special individuals with their online presence and we'd be grad to help you too. We do anything and everything, from providing you a team for video shoots, editing your content, taking Professional Grade photographs, managing your online social medias, everything! You mention it, we have it.</p>
                <p>Increase your base through the help of next gen Professionals, better content, larger fan base, more advertising opportunities. On the fence? Take the leap with our one month limited trial, and once you fall in love with us simply renew your monthly membership and you'll upgrade to our "Let's Make You Shine" pack. Ready to see what's behind the door of opportunity?</p>
            </div>
            <h2>Just look at our work</h2>
            {portfolioImgs.map((image) => 
            <div className="cubes" style={{backgroundImage: `url(${image.images})`}}>
            </div>
            )}
        </div>
    )
}

export default Home
