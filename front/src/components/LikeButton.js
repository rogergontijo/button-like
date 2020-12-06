import React from "react";

export default class LikeButton extends React.Component {
  state = {
    liked: false,
    article: null,
    count: 0    
  };

   Increment = async () => {
    const articleGuid = "D6283F6D-3465-4D37-8C01-8DC4B85AC95D";
    let amountLike = 0; 
    if (this.state.liked)
    {    
        amountLike = -1;
        this.setState({liked: false});
    }
    else
    {
        amountLike = 1;
        this.setState({liked: true});
    }

    const url = "https://localhost:44323/articles/";
    await fetch(url, {
                method: "put",
                headers: { "Content-type": "application/json" },
                body: JSON.stringify({
                    Guid: articleGuid,
                    AmountLike: amountLike
                })
            })
            .then(async () => {
                const response = await fetch(url + articleGuid)
                const data = await response.json();                
                    console.log(data);
                    this.setState({ 
                        article: data, 
                        liked: this.state.liked, 
                        count: data.amountLike 
                    });                    
            })
            .catch(e => console.error(e));    
  };

  async componentDidMount() {
    const articleGuid = "D6283F6D-3465-4D37-8C01-8DC4B85AC95D";
    const url = "https://localhost:44323/articles/" + articleGuid;
    const response = await fetch(url);
    const data = await response.json();    
    this.setState({ article: data, liked: this.state.liked, count: data.amountLike });    
  };  

  render() {
    if (!this.state.article) {
      return <div>didn't get a article</div>;
    }

    return (
      <div>        
        <div><h4>Article Name</h4> {this.state.article.name}</div>
        <div><h4>Article Text:</h4> {this.state.article.text}</div>
        <div><h4>Author Guid:</h4> {this.state.article.authorGuid}</div>
        <button onClick={this.Increment}>Likes: {this.state.count}</button>         
      </div>
    );
  }
}