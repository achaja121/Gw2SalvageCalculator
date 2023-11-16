/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

if not exists (select 1 from dbo.[Rarity])
begin
    insert into dbo.[Rarity] (Name)
    values ('Junk'),
    ('Basic'),
    ('Fine'),
    ('Masterwork'),
    ('Rare'),
    ('Exotic'),
    ('Ascended'),
    ('Legendary')
end

if not exists (select 1 from dbo.[Types])
begin
    insert into dbo.[Types] (Name)
    values ('Armor'),
    ('Back'),
    ('Bag'),
    ('Consumable'),
    ('Container'),
    ('CraftingMaterial'),
    ('Gathering'),
    ('Gizmo'),
    ('JadeTechModule'),
    ('Key'),
    ('MiniPet'),
    ('PowerCore'),
    ('Tool'),
    ('Trait'),
    ('Trinket'),
    ('Trophy'),
    ('UpgradeComponent'),
    ('Weapon')
end
