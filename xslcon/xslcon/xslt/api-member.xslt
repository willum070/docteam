<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="text" indent="no" />
    <xsl:template match="/">
        <xsl:for-each select="doc/members/member">
            <xsl:value-of select="@name"/>
            <xsl:value-of select="summary"/>
            |Parameter|Value|
            |:--------|:----|<xsl:for-each select="param">
                |<xsl:value-of select="@name"/>|<xsl:value-of select="."/>|</xsl:for-each>
            <xsl:value-of select="example"/>
        </xsl:for-each>
    </xsl:template>
</xsl:stylesheet>
