import React from "react";

export default class LikeButton extends React.Component {
  state = {
    liked: true,
    article: null    
  };

  async componentDidMount() {
    const articleGuid = "";
    const url = "https://localhost:44323/articles/" + articleGuid;
    const response = await fetch(url);
    const data = await response.json();
    this.setState({ article: data.results[0], liked: true });
  }

  render() {
    if (this.state.liked) {
      return <div>loading...</div>;
    }

    if (!this.state.article) {
      return <div>didn't get a article</div>;
    }

    return (
      <div>
        <div>{this.state.article.name}</div>
        <div>{this.state.article.text}</div>
        <div>{this.state.article.authorGuid}</div>        
        <div>{this.state.article.amountLike}</div>
      </div>
    );
  }

}