import { React, useState } from "react";
import { Card, CardHeader, CardBody, Image, Stack, Heading, Box, Text, StackDivider } from "@chakra-ui/react";

const ResultCards = () => {
  return (
    <div>
      <Card>
        <CardBody>
          <Image
            src="https://render.guildwars2.com/file/94D19303448005274F24F433016D2CE1AC54057E/2594851.png"
            alt="iconImage"
          />
          <Stack mt="6" spacing="3">
            <Heading size="md">Item Name!</Heading>
            <Text>Item type: Greatsword</Text>
          </Stack>
        </CardBody>
      </Card>
      <Card>
        <CardHeader>
          <Heading size="md">Current Selling Prices</Heading>
        </CardHeader>

        <CardBody>
          <Stack divider={<StackDivider />} spacing="4">
            <Box>
              <Box>
                <Heading size="xs" textTransform="uppercase">
                  Can sell item?
                </Heading>
                <Text pt="2" fontSize="sm">
                  Yes
                </Text>
              </Box>
              <Heading size="xs" textTransform="uppercase">
                Current value on Tradng Post
              </Heading>
              <Text pt="2" fontSize="sm">
                1000g 5s
              </Text>
            </Box>
            <Box>
              <Heading size="xs" textTransform="uppercase">
                Vendor sell value
              </Heading>
              <Text pt="2" fontSize="sm">
                10s
              </Text>
            </Box>
          </Stack>
        </CardBody>
      </Card>
      <Card>
        <CardHeader>
          <Heading size="md">Salvage</Heading>
        </CardHeader>

        <CardBody>
          <Stack divider={<StackDivider />} spacing="4">
            <Box>
              <Box>
                <Heading size="xs" textTransform="uppercase">
                  Is salvageable?
                </Heading>
                <Text pt="2" fontSize="sm">
                  Yes
                </Text>
              </Box>
              <Heading size="xs" textTransform="uppercase">
                Possible value of item salvaged (globs)
              </Heading>
              <Text pt="2" fontSize="sm">
                1g
              </Text>
            </Box>
          </Stack>
        </CardBody>
      </Card>
    </div>
  );
};

export default ResultCards;
