import { React, useState } from "react";
import { Box, Button, Input } from "@chakra-ui/react";
import axios from 'axios';

const Search = () => {
  const [inputText, setInputText] = useState("");
  const [posts, setPosts] = useState([]);

  function handleInputChange(event) {
    console.log(event.target.value);
    setInputText(event.target.value);
  }

  const handleClick = async () => {
    const url =
      "http://gw2salvagecalculator.local/api/SalvageCalculator/search?itemName=" + inputText;

    axios
      .get(url)
      .then((response) => {
        setPosts(response.data);
        console.log(posts);
      })
      .catch((err) => {
        console.log(err);
      });
  };
  
  return (
    <Box
      backgroundImage="url('https://d3b4yo2b5lbfy.cloudfront.net/wp-content/uploads/2017/07/2f4542017-02_LWS3_Ep4_HomeBanner_Blank.jpg')"
      backgroundRepeat="no-repeat"
      background-size="auto"
      padding="200"
    >
      <Box>
        <Input
          placeholder="Input item name here"
          variant="filled"
          onChange={handleInputChange}
        />
        <Button onClick={handleClick}>Search</Button>
      </Box>
    </Box>
  );
};

export default Search;
